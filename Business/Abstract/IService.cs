using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IService<Entity>
    {
        IResult Add(Entity entity);
        IResult Delete(Entity entity);
        IResult Update(Entity entity);
        IDataResult<List<Entity>> GetAll();
        IDataResult<Entity> GetById(int id);
    }
}
