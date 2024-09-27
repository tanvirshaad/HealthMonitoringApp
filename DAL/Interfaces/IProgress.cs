﻿using DAL.EF.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IProgress: IRepoNew<HealthMetrics, int>
    {
        HealthMetrics GetByUserId(int id);
    }
}
