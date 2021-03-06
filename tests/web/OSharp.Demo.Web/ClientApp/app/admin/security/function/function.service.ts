import { Injectable, } from '@angular/core';
import { Observable, } from 'rxjs/Observable';
import { URLSearchParams, Http } from '@angular/http';
import 'rxjs/add/operator/toPromise';

import { DataResult, DataSourceRequestState, toDataSourceRequestString, translateAggregateResults, translateDataSourceResultGroups, } from "@progress/kendo-data-query";
import { GridDataResult, DataStateChangeEvent } from "@progress/kendo-angular-grid";
import { EntityServiceBase, PageData } from '../../../shared/osharp/osharp.models';


export class Function {
    id: string;
    name: string;
    area: string;
    controller: string;
    action: string;
    isController: boolean;
    isAjax: boolean;
    accessType: number;
    isAccessTypeChanged: boolean;
    auditOperationEnabled: boolean;
    auditEntityEnabled: boolean;
    cacheExpirationSeconds: number;
    isCacheSliding: boolean;
    isLocked: boolean
}

@Injectable()
export class FunctionService extends EntityServiceBase<Function> {

    /** 读取列表数据 */
    Read(state?: DataSourceRequestState): Observable<DataResult> {
        var url = "api/admin/function/read";
        return this.ReadInternal(url, state);
    }
}
