using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

using MediatR;
using FluentValidation;
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

            public Handler(DataContext context)
            {
                this.context = context;
            }

            public async Task<List<GuestDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var queryable = context
                    .Guest
                    .OrderBy(x => x.LastName)
                    .AsQueryable();

                return await queryable
                    .Select(x => new GuestDto()
                    {
                        Id = x.Id,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        Email = x.Email,
                        Phone = x.Phone
                    })
                    .ToListAsync();

            }
        }
    }
}
