# Vexel

<p align="center">
  <img src="https://img.shields.io/badge/.NET-10.0-512BD4" alt=".NET 10.0"/>
  <img src="https://img.shields.io/badge/SqlSugar-5.x-00a1ea" alt="SqlSugar"/>
  <img src="https://img.shields.io/badge/LayUI-2.9-blue" alt="LayUI"/>
  <img src="https://img.shields.io/badge/license-MIT-green" alt="MIT License"/>
</p>

> 基于 **ASP.NET Core 10.0（MVC + Web API）+ SqlSugar + LayUI** 的敏捷开发框架。本仓库由 WaterCloud 重命名 / 二次开发而来，源代码完全开源，帮助你解决 C#/.NET 项目中的大量重复工作。

---

## 一、项目简介

- Vexel 是一套基于 ASP.NET Core 10.0（MVC + Web API）+ SqlSugar + LayUI 的敏捷开发框架，可帮助你解决 C#/.NET 项目中的大量重复工作。
- 采用主流架构思想，容易上手、简单易学、学习成本低。
- 可完全实现二次开发，让开发更关注业务逻辑，既能快速提高开发效率、节省人力成本，又不失灵活性。
- 支持 SQL Server / MySQL / Oracle / SQLite 等多种数据库，模块化设计、层次结构清晰，内置一系列企业信息管理基础功能。
- 操作权限基于 RBAC，权限控制精密细致：可控制到导航菜单、功能按钮，乃至行级、列表级、表单字段级。
- 数据权限：精细化数据权限控制，实现不同人员查看不同数据。
- 内置代码生成、表单设计器、流程设计器、内容管理、文件管理、定时任务、多租户等企业级能力。

## 二、功能特性

- **权限管理（RBAC）**：菜单、按钮、数据列、行级、表单字段级权限
- **数据权限**：按部门 / 角色隔离数据
- **代码生成器**：前后端代码一键生成（`Vexel.CodeGenerator`）
- **表单设计器**：拖拉式动态表单与自定义表单
- **流程设计器**：动态设计流程、节点及连线条件
- **内容管理**：内置 wangEditor 富文本编辑器
- **文件管理**：文件上传与下载
- **定时任务**：基于 Quartz（支持集群）
- **多租户**：基于 Database 的多租户（SqlSugar 支持）
- **缓存**：Redis / Memory（单点登录控制）
- **消息队列**：RabbitMQ（事件总线）
- **日志**：操作日志、登录日志、异常日志
- **响应式前端**：兼容电脑、平板、手机及常见浏览器

## 三、技术架构

### 前端技术

- 基础框架：jQuery 3.4.1、LayUI、LayUI mini（开源）
- 图标：Font Awesome 4.7.0 及 LayUI 自带图标
- 客户端校验：LayUI verify
- 富文本编辑器：wangEditor、LayUI editor
- 文件上传：LayUI upload
- 动态页签：LayUI mini miniTab
- 数据表格：LayUI table、soul-table（已完成后端筛选）
- 下拉选择：LayUI select、xmselect
- 树控件：dtree；树状表格：treetable-lay（框架改造，兼容 soul-table、修复固定列等 Bug）
- 穿梭框：LayUI transfer
- 图表：ECharts；日期：LayUI laydate
- 图标选择：IconPicker；省市区：layarea

### 后端技术

- 核心框架：ASP.NET Core 10.0、Web API
- 定时任务：Quartz（Web 可控）
- 持久层：SqlSugar（多数据库、复杂查询、多租户、分库分表）、Chloe
- 安全：过滤器、SQL 注入防护、请求伪造（CSRF）防护
- 服务端校验：模型验证
- 缓存框架：Redis / Memory（单点登录控制）
- 消息队列：RabbitMQ
- 事件总线：Jaina
- 日志管理：NLog（文件 / 可选数据库）
- 工具类：MiniExcel、Newtonsoft.Json、验证码、丰富公共类
- 其他：依赖注入、Swagger / OpenAPI

## 四、环境要求

1. Visual Studio 2022（17.x）或更高版本；或使用 VS Code + .NET 10 SDK
2. 安装 **.NET 10.0 SDK**
3. 默认使用 **SQLite**（无需额外安装数据库，首次启动自动建库并写入种子数据）；如需 SQL Server / MySQL / Oracle，请修改 `appsettings.Development.json` 的数据库连接配置
4. 可选：Redis（单点登录 / 缓存）、RabbitMQ（消息队列）。安装包已置于仓库 `Redis/`、`RabbitMq/` 目录

## 五、快速开始

### 方式一：Visual Studio

1. 使用 Visual Studio 2022+ 打开 `Vexel3.sln`
2. 右键 `Vexel.Web` → **设为启动项目**
3. 按 `F5`（调试）或 `Ctrl+F5`（不调试）运行

### 方式二：命令行

```bash
dotnet restore
dotnet run --project Vexel.Web
```

启动后访问 `http://localhost:5000`（监听端口见 `appsettings.Development.json` 的 `urls`，默认 `http://*:5000`）。

### 默认账号

- 管理员：账号 `admin` / 密码 `0000`

> 首次启动会在 `Vexel.Web/` 下生成 SQLite 数据库文件 `vexelnetdb.db` 并初始化种子数据，请稍候片刻。

## 六、目录结构

```
Vexel-3.x/
├─ Vexel3.sln                    # 解决方案文件
├─ Vexel.Web/                    # ASP.NET Core 主站（MVC + Web API + 静态资源）
├─ Vexel.Code/                   # 公共类库：缓存、扩展、过滤器、操作符、工具类
├─ Vexel.Data/  (程序集 Vexel.DataBase) # 数据访问层：SqlSugar 仓储、DB 上下文
├─ Vexel.Domain/                 # 领域模型：实体、视图模型、种子数据
├─ Vexel.Service/                # 业务逻辑层：各模块 Service、定时任务
├─ Vexel.CodeGenerator/          # 代码生成器
├─ Redis/                        # Redis 安装包与说明
├─ RabbitMq/                     # RabbitMQ 安装包
├─ LICENSE                       # MIT 许可证
└─ README.md                     # 项目说明
```

> 说明：`Vexel.Data` 项目文件夹名与程序集名 `Vexel.DataBase` 为历史命名，保留原结构以保持兼容。

## 七、配置说明（`Vexel.Web/appsettings.Development.json` → `SystemConfig`）

| 配置项 | 说明 |
|---|---|
| `Demo` | 是否演示模式（账号 admin / 0000） |
| `LoginMultiple` | 是否允许同一账号多处登录 |
| `CacheProvider` | 缓存方式：`Memory` / `Redis` |
| `RedisConnectionString` | Redis 连接串（如 `127.0.0.1:6379`） |
| `TokenName` | API Token 名称（默认 `WC-Token`） |
| `LoginExpire` | 登录缓存过期时间（小时） |
| `SqlMode` | 数据库模式：`TenantSql`（多租户）/ `MoreSql`（多库） |
| `ProjectPrefix` | 项目前缀（默认 `vexel`，用于缓存键、表前缀等） |
| `OpenQuartz` | 是否开启定时任务 |
| `SqlConfig` | 数据库连接数组：`DBProvider`（Sqlite/SqlServer/MySql/Oracle）、`DBConnectionString`、`IsInitDb`、`IsSeedData` |
| `RabbitMq` | 消息队列配置（`Enabled` / `HostName` / `UserName` / `Password` / `Port`） |

切换数据库示例（在 `SqlConfig` 中追加一项）：

```json
{
  "DBNumber": "1",
  "DBProvider": "SqlServer",
  "DBConnectionString": "Data Source=.;Initial Catalog=VexelNetDb;User ID=sa;Password=12345678;MultipleActiveResultSets=true;",
  "DBCommandTimeout": 180,
  "IsInitDb": true,
  "IsSeedData": true
}
```

## 八、内置功能模块

- **系统管理（SystemManage）**：用户、角色、部门 / 组织、菜单、模块、按钮、字典、代码生成、表单、流程方案、快捷模块、模板
- **系统组织（SystemOrganize）**：组织、角色授权、数据权限规则、通知公告、系统设置
- **系统安全（SystemSecurity）**：登录日志、操作日志、IP 过滤、定时任务、服务监控
- **流程管理（FlowManage）**：流程实例、表单测试
- **内容管理（ContentManage）**：文章分类、文章资讯
- **文件管理（FileManage）**：上传文件
- **信息管理（InfoManage）**：消息、消息历史
- **订单管理（OrderManagement）**：订单、订单明细

## 九、进阶能力

- **代码生成**：`Vexel.CodeGenerator` 提供单表模板，自动生成实体、Service、Controller 与前端页面。
- **表单 / 流程设计器**：低代码方式设计业务表单与审批流程。
- **部署**：`Vexel.Web/Dockerfile` 提供容器化构建；`Vexel.Web/Properties/PublishProfiles/` 提供发布配置。
- **API 文档**：运行后访问 `/swagger` 查看 OpenAPI 文档（标题 `Vexel API`）。

## 十、许可证

本项目基于 [MIT](./LICENSE) 许可证开源。

> 本仓库由 **Viken** 基于开源项目 WaterCloud 重命名与二次开发而来（重命名为 Vexel）。当前维护者 / 版权持有人：**Viken**（Viken.Wang@outlook.com）。如需调整版权信息，请修改 `LICENSE` 文件顶部。

## 十一、免责声明

- 请勿将本项目用于违反所在国家 / 地区法律法规的用途。
- 本项目按“原样”提供，不对任何使用后果承担责任。

## 十二、致谢

- 感谢原项目 [WaterCloud](https://gitee.com/dotnetchina/WaterCloud) 及其作者 **钱玮鸿** 提供的优秀基础框架。
- 感谢 LayUI、LayUI mini、SqlSugar、Quartz、ECharts 等优秀开源项目。
