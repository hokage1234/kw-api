using dkApi.Interfaces;
using dkApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace dkApi.Controllers
{
    [ApiController]
    [Route("user-info")]
    public class UserInfoController : ControllerBase
    {
        public IUserInfoRepository _userInfoRepository;

        public UserInfoController(IUserInfoRepository userInfoRepository)
        {
            _userInfoRepository = userInfoRepository;
        }

        [HttpGet("all-users")]
        public IList<UserInfo>? GetUsers()
        {
            var result = _userInfoRepository.GetUserInfos();
            return result;
        }

        [HttpGet("user")]
        public UserInfo? GetUser(int id)
        {
            var result = _userInfoRepository.GetUserInfo(id);
            return result;
        }
    }
}