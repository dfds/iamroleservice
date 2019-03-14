using Amazon.IdentityManagement.Model;

namespace AwsJanitor.WebApi.Tests.Stubs
{
    public class AmazonIdentityManagementServiceStubBuilder
    {
        private readonly AmazonIdentityManagementServiceStub _amazonIdentityManagementServiceStub = new AmazonIdentityManagementServiceStub();
        public AmazonIdentityManagementServiceStub WithCreateRoleResponse(CreateRoleResponse createRoleResponse)
        {
            _amazonIdentityManagementServiceStub.CreateRoleResponse = createRoleResponse;

            return _amazonIdentityManagementServiceStub;
        }
    }
}