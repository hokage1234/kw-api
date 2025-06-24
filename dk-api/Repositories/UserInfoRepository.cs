using dkApi.Interfaces;
using dkApi.Models;
using System;

namespace dkApi.Repositories
{
    public class UserInfoRepository : IUserInfoRepository
    {
        IList<UserInfo> listUserInfos;

        public UserInfoRepository()
        {
            listUserInfos = new List<UserInfo>() {
                new UserInfo()
                {
                    Id = 1,
                    FirstName = "Dawid",
                    LastName = "Kowszewicz"
                }, new UserInfo()
                {
                    Id = 2,
                    FirstName = "Daniel",
                    LastName = "Maciag"
                }, new UserInfo()
                {
                    Id = 3,
                    FirstName = "Marcin",
                    LastName = "Kowszewicz"
                }
            };

        }

        public IList<UserInfo> GetUserInfos()
        {
            return listUserInfos;
        }

        public UserInfo? GetUserInfo(int id)
        {
            var targetUsers = listUserInfos?.Where(o => o.Id == id);
            var targetUser = targetUsers?.FirstOrDefault();

            return targetUser;
        }
    }
}