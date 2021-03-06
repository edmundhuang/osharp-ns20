﻿// -----------------------------------------------------------------------
//  <copyright file="IIdentityContract.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2017 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2017-08-18 14:11</last-date>
// -----------------------------------------------------------------------

using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using OSharp.Data;
using OSharp.Demo.Identity.Dtos;
using OSharp.Demo.Identity.Entities;
using OSharp.Dependency;
using OSharp.Entity;


namespace OSharp.Demo.Identity
{
    /// <summary>
    /// 业务契约：身份认证模块
    /// </summary>
    public interface IIdentityContract : IScopeDependency
    {
        #region 用户信息业务

        /// <summary>
        /// 获取 用户信息查询数据集
        /// </summary>
        IQueryable<User> Users { get; }

        #endregion

        #region 角色信息业务

        /// <summary>
        /// 获取 角色信息查询数据集
        /// </summary>
        IQueryable<Role> Roles { get; }

        #endregion

        #region 用户角色信息业务

        /// <summary>
        /// 获取 用户角色信息查询数据集
        /// </summary>
        IQueryable<UserRole> UserRoles { get; }

        /// <summary>
        /// 检查用户角色信息信息是否存在
        /// </summary>
        /// <param name="predicate">检查谓语表达式</param>
        /// <param name="id">更新的用户角色信息编号</param>
        /// <returns>用户角色信息是否存在</returns>
        Task<bool> CheckUserRoleExists(Expression<Func<UserRole, bool>> predicate, Guid id = default(Guid));
        
        #endregion

    }
}