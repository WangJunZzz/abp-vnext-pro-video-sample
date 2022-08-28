import { FormSchema } from "/@/components/Table";
import { BasicColumn } from "/@/components/Table";

import { BlogsServiceProxy,BlogPagingInput } from "/@/services/ServiceProxies";

export const searchFormSchema :FormSchema[]=[
    {
        field:"filter",
        label:"博客名称",
        component:"Input"
    }
]

export const tableColumns : BasicColumn[]=[
    {
        title:"博客名称",
        dataIndex:"name"
    },
    {
        title:"Github",
        dataIndex:"github",
    },
    {
        title:"签名",
        dataIndex:"signature"
    }
]

export async function getTableListAsync(params:BlogPagingInput){
    const blogsServiceProxy= new BlogsServiceProxy();
    return blogsServiceProxy.pageBlog(params);
}

