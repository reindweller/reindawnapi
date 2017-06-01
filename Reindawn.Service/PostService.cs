using Reindawn.Domain.Models;
using Reindawn.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Reindawn.Service
{


    public class PostService : AbstractEntityService<Post>
    {
        public PostService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override Expression<Func<Post, bool>> FindEntityPrimaryById(Guid id)
        {
            return o => o.Id == id;
        }

        protected override Expression<Func<Post, object>>[] Include()
        {
            return null;
        }

        protected override IOrderedQueryable<Post> OrderBy(IQueryable<Post> arg)
        {
            return arg.OrderByDescending(o => o.DatePosted);
        }

    }
}
