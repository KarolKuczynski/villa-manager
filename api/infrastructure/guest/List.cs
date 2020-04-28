using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

using MediatR;
using FluentValidation;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

using persistence;
using model;

namespace infrastructure.guest
{
    public class List
    {
        public class Query : IRequest<List<GuestDto>>
        {
        }

        public class Handler : IRequestHandler<Query, List<GuestDto>>
        {
            private readonly DataContext context;
            private readonly IMapper mapper;

            public Handler(DataContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            public async Task<List<GuestDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var list = await context
                    .Guest
                    .OrderBy(x => x.LastName)
                    .ToListAsync();

                return mapper.Map<List<Guest>, List<GuestDto>>(list);
            }
        }
    }
}
