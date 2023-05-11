using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PROJECT.API.Hubs;
using PROJECT.Service.Extention;
using PROJECT.Service.Interfaces.AD;

namespace PROJECT.API.Controllers.AD
{
    [ApiController]
    [Route("api/[controller]")]
    public class HistoryLoginController : ControllerBase
    {
        private readonly IUserService _service;
        public HistoryLoginController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("Search")]
        public async Task<IActionResult> Search([FromQuery] OnChangeDate date)
        {
            var tranferObject = new TranferObject();
            var data = await _service._context.T_AD_USER_HISTORY.Where(x => x.LOGON_TIME >= DateTime.Parse(date.startDate) && x.LOGON_TIME <= DateTime.Parse(date.finishDate).AddDays(1).AddTicks(-1)).ToListAsync();
            if (_service.Status)
            {
                tranferObject.Data = data;
            }
            return Ok(tranferObject);
        }

        [HttpGet]
        [Route("UserOnline")]
        public async Task<IActionResult> UserOnline()
        {
            var tranferObject = new TranferObject();
            var lstConnectionUser = OnlineCountHub._lstConnectionUser.ToArray().Distinct().ToList();
            var lstHistory = await _service._context.T_AD_USER.Where(x => lstConnectionUser.Contains(x.USER_NAME)).ToListAsync();
            if (_service.Status)
            {
                tranferObject.Data = lstHistory;
            }
            return Ok(tranferObject);
        }
    }
}
