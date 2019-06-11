[![Build Status](https://travis-ci.org/ZhaoQi99/Game-of-Life.svg?branch=master)](https://travis-ci.org/ZhaoQi99/Game-of-Life/tree/master)
[![Release](https://img.shields.io/github/release/ZhaoQi99/Game-of-Life.svg)](https://github.com/ZhaoQi99/Game-of-Life/releases)
[![License](https://img.shields.io/badge/license-GPL--3.0-blue.svg)](https://github.com/ZhaoQi99/Game-of-Life/blob/master/LICENSE)
# Game-of-Life

游戏名：生命游戏(英文名:Game of life)  
开发语言:C#  
开发环境：Visual Studio 2015  

## 游戏规则
- 如果一个细胞周围有3个细胞为生（一个细胞周围共有8个细胞），则该细胞为生（即该细胞若原先为死，则转为生，若原先为生，则保持不变） 。
- 如果一个细胞周围有2个细胞为生，则该细胞的生死状态保持不变；
- 在其它情况下，该细胞为死（即该细胞若原先为生，则转为死，若原先为死，则保持不变）


## 功能需求
- [x] 游戏核心逻辑
- [x] 采用可视化界面展示结果(所有细胞的状态)
- [ ] 预先指定每个细胞的状态
- [x] 可以控制动画的速度

## 实现功能
- 开始游戏、暂停游戏、停止游戏
- 按照固定样式设置网格的状态(即预先指定细胞状态)
- 设置网格中细胞数目
- 设置动画速率
- 背景音乐(附加)
- 设置网格中细胞颜色(附加)

## 文件清单
- Cell.cs　　　　　细胞类
- Field.cs 　   　　　放置所有细胞的网格类
- Game.cs　　　　游戏核心逻辑类
- FormMain.cs 　　游戏界面类
- Program.cs　　　程序入口
- Cskin.dll　　　　 第三方皮肤库

## Demo
![image](https://user-images.githubusercontent.com/25344334/59282416-7d35ad00-8c9b-11e9-8b5c-5cd9ba884f34.png)
