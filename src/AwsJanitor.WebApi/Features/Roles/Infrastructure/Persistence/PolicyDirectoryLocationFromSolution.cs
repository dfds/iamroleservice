using System.IO;

namespace AwsJanitor.WebApi.Features.Roles.Infrastructure.Persistence
{
    public static class PolicyDirectoryLocationFromSolution
    {
        public static PolicyDirectoryLocation Create()
        {
            var baseFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var filesFolder = Path.Combine(baseFolder, "Features/Roles/Infrastructure/Persistence/PolicyTemplates");
            
            
            return new PolicyDirectoryLocation(filesFolder);
        }
    }
}