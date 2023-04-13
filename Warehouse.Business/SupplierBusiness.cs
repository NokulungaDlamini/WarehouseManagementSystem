﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.DataAccess;
using Warehouse.Entity;

namespace Warehouse.Business
{
    public class SupplierBusiness
    {

        SupplierRepository _supplierRepository = new SupplierRepository();


        public int supplierinsertDetails(SupplierEntity supplierEntity)
        {
            return _supplierRepository.supplierinsert(supplierEntity);
        }

        public int supplierUpdateDetails(SupplierEntity supplierEntity)
        {
            return _supplierRepository.supplierUpdate(supplierEntity);
        }

        public int supplierDeleteDetails(SupplierEntity supplierEntity)
        {
            return _supplierRepository.supplierDelete(supplierEntity);
        }
    }
}
