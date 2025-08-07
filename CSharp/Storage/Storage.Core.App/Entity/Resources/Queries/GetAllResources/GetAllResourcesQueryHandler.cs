using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Storage.Core.App.Interfaces;

namespace Storage.Core.App.Entity.Resources.Queries.GetAllResources
{
    public class GetAllResourcesQueryHandler: IRequestHandler<GetAllResourcesQuery, GetAllResourcesVM>
    {
        private readonly IResourcesDBContext _resDbContext;
        private readonly IMapper _mapper;

        public GetAllResourcesQueryHandler(IResourcesDBContext userDbContext, IMapper mapper)
        {
            _resDbContext = userDbContext;
            _mapper = mapper;
        }

        async public Task<GetAllResourcesVM> Handle(GetAllResourcesQuery request, CancellationToken cancellationToken)
        {
            var entities = await _resDbContext.resources
                .ProjectTo<GetAllResourcesDTO>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new GetAllResourcesVM { Resources = entities };
        }
    }
}
