# QuartzServerTask
QuartzServerTask是基于Quarzt.Net和Log4Net这2个目前流行的组件进行扩展的任务调度快速开发框架；大部分配置和日志记录都可以简单直接使用，可以重点只关注任务业务逻辑层开发
# 主要特性：
### 1、通过log4net组件进行日志记录，可以分开对info和error日志进行分开记录，无需配置直接可以使用
### 2、新增任务只需实现基类方法完成自身业务逻辑即可，不需要关注大部分配置和日志异常记录
### 3、使用TopShelf进行服务后台安装，只需简单启动即可安装成后台服务进行运行
