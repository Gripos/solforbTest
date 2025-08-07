using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Storage.Core.App.Entity.Resources.Commands.DelResource
{
    public class DelResourceCommand: IRequest<Unit>
    {
        public int ResId { get; set; }
    }
}
