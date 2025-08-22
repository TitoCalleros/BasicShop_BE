using AutoMapper;
using BasicShopAPI.API.DTOs.Products;
using BasicShopAPI.Application.CQRS.Commands.Products;
using BasicShopAPI.Application.CQRS.Handlers.Products;
using BasicShopAPI.Application.CQRS.Queries.Products;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace BasicShopAPI.API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly CreateProductHandler _createHandler;
        private readonly UpdateProductHandler _updateHandler;
        private readonly DeleteProductHandler _deleteHandler;
        private readonly GetProductByIdHandler _getByIdHandler;
        private readonly GetAllProductsHandler _getAllHandler;
        private readonly IMapper _mapper;

        public ProductsController(CreateProductHandler createHandler, UpdateProductHandler updateHandler, DeleteProductHandler deleteHandler, GetProductByIdHandler getByIdHandler, GetAllProductsHandler getAllHandler, IMapper mapper )
        {
            this._createHandler = createHandler;
            this._updateHandler = updateHandler;
            this._deleteHandler = deleteHandler;
            this._getByIdHandler = getByIdHandler;
            this._getAllHandler = getAllHandler;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductResponseDTO>> GetAll(CancellationToken ct)
        {
            var products = await _getAllHandler.Handle(new GetAllProductsQuery());
                
            return products.Any()
                ? _mapper.Map<IEnumerable<ProductResponseDTO>>(products)
                : [];
        }

        [HttpGet("{id:guid}", Name = "GetById")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken ct)
        {
            return await _getByIdHandler.Handle(new GetProductByIdQuery(id)) is { } product
                ? Ok(_mapper.Map<ProductResponseDTO>(product))
                : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProductRequestDTO request, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var cmd = _mapper.Map<CreateProductCommand>(request);
            var newId = await _createHandler.Handle(cmd);

            var qryGet = new GetProductByIdQuery(newId);
            var created = await _getByIdHandler.Handle(qryGet);
            var dto = _mapper.Map<ProductResponseDTO>(created);
            return CreatedAtRoute("GetById", new { id = newId }, dto);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateProductRequestDTO request, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var cmd = _mapper.Map<UpdateProductCommand>(request);

            try
            {
                await _updateHandler.Handle(cmd);
            }
            catch (KeyNotFoundException) 
            {
                return NotFound("The Id does not exists");
            }

            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete (Guid id, CancellationToken ct)
        {
            try
            {
                var cmd = new DeleteProductCommand(id);

                await _deleteHandler.Handle(cmd);
            }
            catch (KeyNotFoundException)
            {
                return NotFound("The Id does not exists");
                throw;
            }

            return NoContent();
        }
    }
}
