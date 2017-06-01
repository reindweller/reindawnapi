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

    public class CommentService : AbstractEntityService<Comment>
    {
        public CommentService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override Expression<Func<Comment, bool>> FindEntityPrimaryById(Guid id)
        {
            return o => o.Id == id;
        }

        protected override Expression<Func<Comment, object>>[] Include()
        {
            return null;
        }

        protected override IOrderedQueryable<Comment> OrderBy(IQueryable<Comment> arg)
        {
            return arg.OrderByDescending(o => o.DatePosted);
        }

    }
}
