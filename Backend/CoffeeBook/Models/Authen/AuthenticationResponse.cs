using CoffeeBook.Models.Enum;

namespace CoffeeBook.Models.Authen
{
    public record AuthenticationResponse
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public RoleEnum Role { get; set; }
        public string Token { get; set; }

        public AuthenticationResponse(Account account, string token)
        {
            Id = account.Id;
            Username = account.Username;
            switch (account.RoleId)
            {
                case 1:
                    Role = RoleEnum.Admin;
                    break;

                case 2:
                    Role = RoleEnum.Manager;
                    break;

                case 3:
                    Role = RoleEnum.Staff;
                    break;

                case 4:
                    Role = RoleEnum.Shipper;
                    break;

                case 5:
                    Role = RoleEnum.Customer;
                    break;

                default:
                    break;
            }
            Token = token;
        }
    }
}