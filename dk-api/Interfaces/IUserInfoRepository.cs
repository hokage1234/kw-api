using dkApi.Models;

namespace dkApi.Interfaces
{
    public interface IUserInfoRepository
    {
        IList<UserInfo>? GetUserInfos();
        UserInfo? GetUserInfo(int id);
    }
}
