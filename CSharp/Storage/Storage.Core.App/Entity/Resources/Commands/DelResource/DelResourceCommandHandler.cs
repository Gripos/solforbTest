using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Storage.Core.App.Interfaces;
using Storage.Core.Domain;

namespace Storage.Core.App.Entity.Resources.Commands.DelResource
{
    public class DelResourceCommandHandler: IRequestHandler<DelResourceCommand, Unit>
    {
        private readonly IResourcesDBContext _resDbContext;

        public DelResourceCommandHandler(IResourcesDBContext context) { _resDbContext = context; }


        public async Task<Unit> Handle(DelResourceCommand request, CancellationToken cancellationToken)
        {
            var entity = await _resDbContext.resources.FirstOrDefaultAsync(
                    item => item.resId == request.ResId, cancellationToken);

            if (entity == null || entity.resId != request.ResId)
            {
                throw new Exception("Проблемы с " + nameof(Resource) + request.ResId);
            }

            _resDbContext.resources.Remove(entity);
            await _resDbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
