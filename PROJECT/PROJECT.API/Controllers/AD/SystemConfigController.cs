using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PROJECT.Core.Models.AD;
using PROJECT.Core.Models.MD;
using PROJECT.Service.Extention;
using PROJECT.Service.Filter.AD;
using PROJECT.Service.Filter.MD;
using PROJECT.Service.Interfaces.MD;

namespace PROJECT.API.Controllers.MD
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class SystemConfigController : ControllerBase
    {
        public readonly ISystemConfigService _service;
        public SystemConfigController(ISystemConfigService service)
        {
            _service = service;
        }

        [HttpGet]
        //[Right(ClaimTypes.Role, "R1, R192")]
        [Route("GetList")]
        public async Task<IActionResult> GetList()
        {
            var tranferObject = new TranferObject();
            if (_service.Status)
            {
                tranferObject.Data = await _service.GetAll();
            }
            return Ok(tranferObject);
        }

        [HttpPut]
        //[Right(ClaimTypes.Role, "R1, R192")]
        [Route("Update")]
        public async Task<IActionResult> Update([FromBody] T_AD_SYSTEM_CONFIG SystemConfig)
        {
            var tranferObject = new TranferObject();
            var pagination = await _service.Update(SystemConfig);
            if (_service.Status)
            {
                tranferObject.Data = pagination;
                tranferObject.Message = new MessageObject()
                {
                    Code = "S1000",
                    Message = "Thành công!",
                    MessageDetail = "Cập nhật thông tin cấu hình hệ thống thành công!",
                    MessageType = "S"
                };
            }
            return Ok(tranferObject);
        }
    }
}
