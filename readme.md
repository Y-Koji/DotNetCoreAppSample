
# DotNetCoreAppSample
.Net Core 2 でツール等を作成する際に必要になるであろうパッケージを設定したプロジェクトです．

# パッケージリスト
- Microsoft.Extensions.DependencyInjection: 流行りのAOPでプログラムの実装をする用のアセンブリ
- NLog: ロギングライブラリ
- NLog.Extensions.Logging: AOPでNLogのログ用オブジェクトの管理を行うための拡張メソッド群

## DB系(SQLite)
- Microsoft.EntityFrameworkCore.SQLite
- Microsoft.EntityFrameworkCore.SQLite.Core
- Microsoft.EntityFrameworkCore.Tools

# Migration
コードファーストでDBを設計する用のコマンドがEntityFramworkCore.Toolsに組み込まれている．
Visual Studio 2017 のパッケージマネージャコンソールで以下のコマンドを利用することでマイグレーションができる．

## Add-Migration [MigrationName]
マイグレーション設定を新規追加する．
MigrationNameは任意の文字列を渡す．

## Update-Database
クラスファイルからSQLiteのデータベースファイルを自動生成する．
