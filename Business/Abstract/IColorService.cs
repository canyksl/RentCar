﻿using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface IColorService
    {
        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetById(int id);
    }
}
