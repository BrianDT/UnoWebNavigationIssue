
namespace ServiceInterfaces
{
    using System;
    using System.Threading.Tasks;

    public interface INavigationService
    {
        Task ExternalPageNavigation(Uri targetUri);
    }
}