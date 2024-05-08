using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace BlHyblidSample;

public partial class Form1 : Form
{
    private HostInterface HostIF;
    public Form1()
    {
        InitializeComponent();
        var services = new ServiceCollection();
        services.AddWindowsFormsBlazorWebView();
        // Singletonオブジェクトの作成
        HostIF = new HostInterface();
        // コンポーネントから呼び出されるイベントハンドラ
        HostIF.ComponentEvent += On_ClientEvent;
        // Singletonオブジェクトをコンポーネントサービスに追加
        services.AddSingleton<IHostInterface>(HostIF);
        blView.HostPage = @"wwwroot\index.html";
        blView.Services = services.BuildServiceProvider();
        blView.RootComponents.Add<Counter>("#app");
    }
    /// <summary>
    /// インクリメントボタンクリックイベントハンドラ
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void On_btnIncrement_Click(object sender, EventArgs e) {
        // Singletonのカウンタをインクリメント
        HostIF.Count++;
        lblMessage.Text = $"カウント：{HostIF.Count}";
        // コンポーネント表示を更新
        HostIF.ComponentRefresh();
    }
    /// <summary>
    /// コンポーネントイベントハンドラ
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void On_ClientEvent(object sender, EventArgs e) {
        // ホストの表示を更新
        lblMessage.Text = $"カウント：{HostIF.Count}";
    }
}
