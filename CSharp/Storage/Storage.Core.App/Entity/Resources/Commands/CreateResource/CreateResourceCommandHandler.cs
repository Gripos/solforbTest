using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Storage.Core.App.Interfaces;
using Storage.Core.Domain;

namespace Storage.Core.App.Entity.Resources.Commands.CreateResource
{
    public class CreateResourceCommandHandler: IRequestHandler<CreateResourceCommand, int>
    {
        private readonly IResourcesDBContext _resContext;

        public CreateResourceCommandHandler(IResourcesDBContext context) { _resContext = context; }

        async public Task<int> Handle(CreateResourceCommand request, CancellationToken cancellationToken)
        {
            var ent = new Resource
            {
                name = request.Name,
                isArchive = false,
            };
            await _resContext.resources.AddAsync(ent, cancellationToken);
            await _resContext.SaveChangesAsync(cancellationToken);

            return ent.resId;
        }
    }
}
