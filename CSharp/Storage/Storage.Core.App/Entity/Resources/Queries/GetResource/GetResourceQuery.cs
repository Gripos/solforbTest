using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Storage.Core.App.Entity.Resources.Queries.GetResource
{
    public class GetResourceQuery: IRequest<ResourceVm>
    {
        public int ResId { get; set; }
    }
}
