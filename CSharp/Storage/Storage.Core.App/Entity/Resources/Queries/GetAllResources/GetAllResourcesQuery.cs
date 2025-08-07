using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Storage.Core.App.Entity.Resources.Queries.GetAllResources
{
    public class GetAllResourcesQuery: IRequest<GetAllResourcesVM>
    {
    }
}
