<template>
    <div id="grid-box">
      <kendo-grid ref="grid" v-bind="gridOptions"></kendo-grid>
    </div>
</template>

<script lang="ts">
import Vue from "vue";
import Component from "vue-class-component";
import $ from "jquery";
import { KendoGrid } from "@progress/kendo-grid-vue-wrapper";
import { osharp } from "../../../shared/osharp";
import { kendoui } from "../../../shared/osharp.kendoui";

@Component({})
export default class UserRoleComponent extends kendoui.GridVueBase {
  protected moduleName = "userrole";

  constructor() {
    super();
  }

  protected GetModel() {
    return {
      model: {
        id: "Id",
        fields: {
          UserId: { type: "number", editable: false },
          RoleId: { type: "number", editable: false },
          UserName: { type: "string", validation: { required: true } },
          RoleName: { type: "string", validation: { required: true } },
          IsLocked: { type: "boolean" },
          CreatedTime: { type: "date", editable: false }
        }
      }
    };
  }
  protected GetGridColumns(): kendo.ui.GridColumn[] {
    return [
      {
        field: "UserId",
        title: "用户",
        width: 150,
        template: "#=UserId#.#=UserName#"
      },
      {
        field: "RoleId",
        title: "角色",
        width: 150,
        template: "#=RoleId#.#=RoleName#"
      },
      {
        field: "IsLocked",
        title: "锁定",
        width: 95,
        template: d => kendoui.Controls.Boolean(d.IsLocked)
      },
      {
        field: "CreatedTime",
        title: "注册时间",
        width: 130,
        format: "{0:yy-MM-dd HH:mm}"
      }
    ];
  }

  protected GetGridOptions(
    dataSource: kendo.data.DataSource
  ): kendo.ui.GridOptions {
    var options = super.GetGridOptions(dataSource);
    //options.columnMenu = { sortable: false };
    options.toolbar = ["save", "cancel"];
    return options;
  }

  created() {
    super.CreatedBase();
  }
  mounted() {
    super.MountedBase();
  }
}
</script>

<style scoped>
#grid-box {
  padding: 10px;
}
</style>