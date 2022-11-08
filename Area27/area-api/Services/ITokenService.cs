using area_api.Models.Execucoes;
namespace area_api.Services
{
    public interface ITokenService
    {
        string GerarToken(string key, string issuer,string audience, UserModel user);
    }
}
