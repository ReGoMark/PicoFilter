<img src="https://raw.githubusercontent.com/ReGoMark/PicoFilter/refs/heads/main/Resources/Assets/head_color.png" />

<div align="center">
    
<a href="./LICENSE">
    <img src="https://img.shields.io/github/license/ReGoMark/PicoFilter.svg?style=for-the-badge" alt="license"></a>
<a href="https://github.com/ReGoMark/PicoFilter/commits/main">
    <img src="https://img.shields.io/github/last-commit/ReGoMark/PicoFilter?style=for-the-badge"></a>
<a href="https://github.com/ReGoMark/PicoFilter/stargazers">
    <img src="https://img.shields.io/github/stars/ReGoMark/PicoFilter.svg?style=for-the-badge" alt="stars"></a>
<a href="https://github.com/ReGoMark/PicoFilter/release">
    <img src="https://img.shields.io/github/release/ReGoMark/PicoFilter.svg?style=for-the-badge" alt="release"></a>
    
</div>

## ✅PicoFilter - 图片筛选、命名、排序和格式转换程序

<div align="right">
    
联系&反馈：regmvks@outlook.com

</div>

PicoFilter 是一款简单易用的图片整理工具，支持读取JPEG、PNG、BMP、ICO和GIF格式的图像文件，轻松实现筛选分类、批量重命名、分析和批量格式转换等的功能。程序基于.NET Framework框架开发，占用体积小且配置要求低，遵循Windows设计规范。本程序开源免费，不得用于商业用途。

>[!TIP]
>1. 运行前请安装 [方正黑体_GBK](./Fonts/方正黑体GBK.ttf)字体。
>2. 运行前请安装[.NET Framework 4.7.2 Runtime](https://dotnet.microsoft.com/zh-cn/download/dotnet-framework/thank-you/net472-web-installer)，否则程序将无法运行。
>3. 运行显示器分辨率必须大于1000*600，否则布局会出现错误。
>4. 项目完全免费开源，仅供交流和学习使用，任何人不得以任何形式用于商业用途或未经授权的分发。

<details open>
<summary> 📖内容概览 </summary>

- [📒使用说明](#使用说明)  
- [🍰特色功能](#特色功能一览)
- [📷界面展示](#程序界面展示)
- [⏬下载](#下载)
- [💗打赏](#打赏)
- [🙏鸣谢](#鸣谢)
- [💾PICOFILTER 许可协议](https://github.com/ReGoMark/PicoFilter/blob/0676005b5875f35327bca930f663c78daa085f33/LICENSE)
- [💾字体资源 许可协议](https://github.com/ReGoMark/PicoFilter/blob/b5f17258e014ead0f17e5795f446b78cd2ae6bc7/Fonts/%E5%A3%B0%E6%98%8E%20-%20Statement.txt)

</details>

## 📒使用说明

* 说明文档 *[第一稿完成]*：[PicoFilter 2.0.x 使用说明](https://flowus.cn/regmvks/share/e717713c-be23-4124-b364-878960e75a4e?code=98NZC1)

## 🍰特色一览
    
| 功能 | 详细说明 |备注|
|-----------|--------|--------|
|格式筛选|勾选任意格式（一个或多个）即可将符合项目加载到筛选列表中|可以和`分辨率筛选`组合使用|
|分辨率筛选|支持符合分辨率筛选、大于/小于分辨率筛选、排除符合分辨率筛选、忽略方向筛选|可以和`格式筛选`组合使用|
|分析和统计|查看当前文件夹中各个格式占比、大小，文件夹的创建日期等信息|筛选结果支持导出为`Xlsx`文件|
|导出结果|支持隔离（将筛选结果与其他原文件分隔）、删除、移动、复制和一键保存到桌面等功能|
|导视|加载当前目录下的文件夹结构，可以实现快速跳转或返回上一级等操作|支持`拖入文件夹`操作|
|搜索|可以限定搜索范围（格式、分辨率、文件名、修改日期）或者全局搜索|
|星标|指定关键词（`正规则表达式`），并对带有关键词的项目添加“★”标记|**`2.0`新增**|
|排序|列表内项目排序，排序依据为字符串、序号、分辨率、大小、修改日期|
|命名|筛选结果批量重命名，自定义重命名格式（`正规则表达式`）|可独立使用|
|转换|筛选结果批量格式转换，可以设置转换质量和背景色|可独立使用；**`2.0`新增**|
|拆分|对文件名拆分为文本块，可以自由选择复制或快速上屏|**`2.0.3`新增**
|压缩|将筛选结果生成为压缩包|**`2.0.4`新增**

## 📷程序界面展示
* 主界面
<img src="https://raw.githubusercontent.com/ReGoMark/PicoFilter/refs/heads/main/Screenshots/main0.png" />

* 筛选
<img src="https://raw.githubusercontent.com/ReGoMark/PicoFilter/refs/heads/main/Screenshots/filt.png" />

* 查找
<img src="https://raw.githubusercontent.com/ReGoMark/PicoFilter/refs/heads/main/Screenshots/search.png" />

* 星标
<img src="https://raw.githubusercontent.com/ReGoMark/PicoFilter/refs/heads/main/Screenshots/tag.png"  />

* 导视
<img src="https://raw.githubusercontent.com/ReGoMark/PicoFilter/refs/heads/main/Screenshots/guide.png" />

* 重命名
<img src="https://raw.githubusercontent.com/ReGoMark/PicoFilter/refs/heads/main/Screenshots/rename.png" />

* 格式转换
<img src="https://raw.githubusercontent.com/ReGoMark/PicoFilter/refs/heads/main/Screenshots/convert.png" />

* 文件名拆分
<img src="https://raw.githubusercontent.com/ReGoMark/PicoFilter/refs/heads/main/Screenshots/split.png" />

* 分析
<img src="https://raw.githubusercontent.com/ReGoMark/PicoFilter/refs/heads/main/Screenshots/analysis.png" />

## ⏬下载
* 发布页（优先更新）：https://github.com/ReGoMark/PicoFilter/releases
* 蓝奏云（随后更新）：链接：https://wwza.lanzouo.com/b0j0rzifa 密码：f5zh



## 💗打赏
如果你喜欢这个程序，觉得它对你有帮助，欢迎通过赞助支持作者的持续开发与维护！每一份支持，都是我继续优化和更新的动力。无论是一次性打赏，还是持续支持，都将被深深感激！

<img src="https://raw.githubusercontent.com/ReGoMark/PicoFilter/refs/heads/main/Resources/Assets/wechat_sponsor.jpg" alt="二维码截图" style="max-width: 80%; height: auto;" />

## 🙏鸣谢

Picofilter 的诞生离不开开源社区的支持。此外，感谢 [@洛初](https://github.com/gongfuture) 对我的指导，帮助我完善了`说明文档`和一些`Git`相关事宜。除此之外，本程序还使用了以下组件和IDE，这些开发者的辛勤付出，不胜感激。

* [MertoModernUI](https://github.com/dennismagno/metroframework-modern-ui)
* [EPPlus](https://github.com/EPPlusSoftware/EPPlus)
* [VisualStudio 2022](https://visualstudio.microsoft.com/zh-hans/vs/)

## 🤔聊点别的
### 程序从何而来？
2024年九月份的时候，我接手了`PAA像素艺术大赛`的作品收集工作和运营工作。在此期间，选手们提交的作品很多不符合要求，使用Windows资源管理器没法快速的筛选出不符合/符合要求的文件。为此在开源社区的帮助下，我制作了这一款软件，供大赛内部使用。后来我把他继续完善，放到了Github仓库上分享给大家，一起学习和交流。在一年多的累计更新中，PicoFilter 的版本号从1.2迭代到2.0.2，新增了许许多多的功能。

### 程序的名字怎么起的？
最开始作为一款作品筛选工具，我第一个想到的是works screening（确实不好听）。后来随着初代软件的制作完毕，我觉得有必要起一个好一点的名字了，于是把Picture弱化成Pico，加上Filter，便合成了PicoFilter这个名字。
