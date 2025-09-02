# Himekuri

日めくりカレンダー

「毎日修造」みたいに勝手に気合の入る言葉を表示します。
テキストファイルから読み込もうとか、画面から入力できるようにしようとか、いろいろ考えててコードまとまってません。


これは C# / .NET のプロジェクトです。  
Visual Studio ソリューションとして作成されています。

## 📂 プロジェクト構成
Himekuri.sln # ソリューションファイル<br>
Himekuri/ # プロジェクト本体<br>
├─ Program.cs # エントリーポイント<br>
├─ Form1.cs # メインフォーム<br>
└─ その他のソースコード<br>

## 🚀 実行方法

1. **.NET SDK または Visual Studio** をインストールしてください  
   - [Download .NET](https://dotnet.microsoft.com/download)  
   - [Visual Studio](https://visualstudio.microsoft.com/ja/)  

2. Visual Studio で `Himekuri.sln` を開きます  

3. **F5キー** でデバッグ実行できます  

   またはターミナルから以下のコマンドを実行してください:

   ```bash
   cd Himekuri
   dotnet run
