# unity 的基础部分
这里记录 unity 中脚本开发的过程基础，作为之后的工程范式。

## 编辑器适配
在 `unity` 中选择 `edit` --> `preference` --> `External Tools` 中的 `External Script Editor` 配置为 `vscode` 安装的路径，比如我的就是 `D:\Program Files\Microsoft VS Code\Code.exe`，同时勾选 `Editor Attaching`，配置完成后，在 `unity` 中点击相应的脚本时就会跳转到 `vscode` 中进行编辑。

上述配置完成时，`unity` 会自动的向工程目录中添加 `.vscode/settings.json`，屏蔽与脚本编辑无关的目录与文件（比如.meta文件之类），方便在 `.vscode` 中的开发。

// TODO 调试过程以及剩余部分，在完成demo教程后继续补充。

## unity 工程结构

## unity 包管理

## untiy asset store 相关

## git 相关注意事项