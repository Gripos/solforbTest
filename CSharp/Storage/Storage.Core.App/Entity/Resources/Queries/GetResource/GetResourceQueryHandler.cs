using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Storage.Core.App.Interfaces;
using Storage.Core.Domain;

namespace Storage.Core.App.Entity.Resources.Queries.GetResource
{
    public class GetResourceQueryHandler: IRequestHandler<GetResourceQuery, ResourceVm>
    {
        private readonly IResourcesDBContext _resContext;
        private readonly IMapper _mapper;

        public GetResourceQueryHandler(IResourcesDBContext userDbContext, IMapper mapper)
        {
            _resContext = userDbContext;
            _mapper = mapper;
        }

        async public Task<ResourceVm> Handle(GetResourceQuery request, CancellationToken cancellationToken)
        {
            var entity = await _resContext.resources
                 .FirstOrDefaultAsync(ent => ent.resId == request.ResId, cancellationToken);

            if (entity == null || entity.resId != request.ResId)
            {
                throw new Exception("Проблемы с " + nameof(Resource) + request.ResId);
            }

            return _mapper.Map<ResourceVm>(entity);

        }
    }
}
