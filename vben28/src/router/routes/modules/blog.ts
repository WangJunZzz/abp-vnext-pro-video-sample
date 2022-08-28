import type { AppRouteModule } from '/@/router/types';
import { LAYOUT } from '/@/router/constant';
const blog: AppRouteModule = {
  path: '/blogs',
  name: '博客管理',
  component: LAYOUT,
  meta: {
    orderNo: 30,
    icon: 'ant-design:contacts-outlined',
    title: "博客",
    policy:"Blog"
  },
  children: [
    {
      path: 'blogs',
      name: '博客',
      component: () => import('/@/views/blogs/index.vue'),
      meta: {
        title: "博客管理",
        icon: 'ant-design:switcher-filled',
        policy:"Blog.BlogManagement"
      },
    },
  ],
};

export default blog;
