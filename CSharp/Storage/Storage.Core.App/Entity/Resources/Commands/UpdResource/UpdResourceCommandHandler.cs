using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Storage.Core.App.Interfaces;
using Storage.Core.Domain;

namespace Storage.Core.App.Entity.Resources.Commands.UpdResource
{
    public class UpdResourceCommandHandler: IRequestHandler<UpdResourceCommand, Unit>
    {
        private readonly IResourcesDBContext _resContext;

        public UpdResourceCommandHandler(IResourcesDBContext context) { _resContext = context; }

        public async Task<Unit> Handle(UpdResourceCommand request, CancellationToken cancellationToken)
        {
            var entity = await _resContext.resources
                .FirstOrDefaultAsync(item => item.resId == request.ResId, cancellationToken);

            if (entity == null)
            {
                throw new Exception("Проблемы с " + nameof(Resource) + request.ResId);
            }

            entity.name = request.NewName;

            await _resContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
