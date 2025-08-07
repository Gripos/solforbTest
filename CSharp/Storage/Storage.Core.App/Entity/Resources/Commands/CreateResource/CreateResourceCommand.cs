using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Storage.Core.App.Entity.Resources.Commands.CreateResource
{
    public class CreateResourceCommand : IRequest<int>
    {
        public required string Name { get; set; }
    }
}
