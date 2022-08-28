<template>
  <div>
    <BasicTable @register="registerTable" size="small">
    </BasicTable>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import { BasicTable, useTable } from "/@/components/Table";
import { tableColumns, searchFormSchema, getTableListAsync } from "/@/views/blogs/index";

export default defineComponent({
  name: "Blog",
  components: {
    BasicTable
  },
  setup() {
    // table配置
    const [registerTable, { reload }] = useTable({
      columns: tableColumns,
      formConfig: {
        labelWidth: 70,
        schemas: searchFormSchema
      },
      api: getTableListAsync,
      showTableSetting: true,
      useSearchForm: true,
      bordered: true,
      canResize: true,
      showIndexColumn: true,
      immediate: true,
      scroll: { x: true }
    });

    return {
      registerTable,
      reload
    };
  }
});
</script>
