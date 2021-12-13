﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IRepository<TEntity,ID>
    {

        List<TEntity> GetAll();
        TEntity Get(ID id);
        void Insert(TEntity entity);
        void Upadte(TEntity entity);
        void Delete(ID id);
    }
}
