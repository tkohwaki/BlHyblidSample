namespace BlHyblidSample;

public delegate void OnClientEvent(object sender, EventArgs e);
public interface IHostInterface {
    public string Message { get; set; }
    public int Count { get; set; }
    /// <summary>
    /// コンポーネントのリフレッシュ等を行なうメソッド
    /// (コンポーネント側でセットする)
    /// </summary>
    /// <value></value>
    public Action ComponentRefresh { get; set; }
    /// <summary>
    /// コンポーネントでイベントが発生した時に呼ばれるホスト側イベントハンドラ
    /// </summary>
    public event OnClientEvent ComponentEvent;
    /// <summary>
    /// コンポーネント側からイベントを発生させるメソッド
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void ExecClientEvent(object sender, EventArgs e);
}
public class HostInterface : IHostInterface {
    public string Message { get; set; } = null!;
    public int Count { get; set; } = 0;
    public Action ComponentRefresh { get; set; } = null!;
    public event OnClientEvent ComponentEvent = null!;
    public void ExecClientEvent(object sender, EventArgs e) {
        ComponentEvent.Invoke(sender,e);
    }
}