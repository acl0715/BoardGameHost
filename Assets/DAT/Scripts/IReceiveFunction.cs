namespace DAT
{
    public interface IReceiveFunction
    {
        /// <summary>
        /// 渡された、IGameDataReceiverのメソッドを使ってデータを取り出して、
        /// 対応コマンドかを調べて、そうであれば、さらにデータを取り出して処理をする。
        /// 自分が、データを処理したら、trueを返す。
        /// </summary>
        /// <param name="receiver">受信したデータのインスタンス</param>
        /// <returns>自分が処理したら、true。何もせずに次に渡すならfalse</returns>
        bool TryProcedure(IGameDataReceiver receiver);
    }
}
