using Abp.Domain.Services;

namespace Framework
{
    public abstract class FrameworkDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected FrameworkDomainServiceBase()
        {
            LocalizationSourceName = FrameworkConsts.LocalizationSourceName;
        }
    }
}
