﻿using System.Collections.Generic;

namespace My.Admin.Service.Admin.Api.Input
{
    /// <summary>
    /// 接口同步
    /// </summary>
    public class ApiSyncInput
    {
        public List<ApiSyncDto> Apis { get; set; }
    }
}