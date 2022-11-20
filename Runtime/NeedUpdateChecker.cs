namespace Kogane
{
    /// <summary>
    /// アップデートが必要かどうかを確認するためのクラス
    /// </summary>
    public static class NeedUpdateChecker
    {
        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// アップデートが必要なバージョンなら true を返します
        /// </summary>
        public static bool IsNeedUpdate
        (
            string currentVersion,
            string minimumVersion
        )
        {
            return IsNeedUpdate
            (
                currentVersion: int.Parse( currentVersion.Replace( ".", "" ) ),
                minimumVersion: int.Parse( minimumVersion.Replace( ".", "" ) )
            );
        }

        /// <summary>
        /// アップデートが必要なバージョンなら true を返します
        /// </summary>
        public static bool IsNeedUpdate
        (
            int currentVersion,
            int minimumVersion
        )
        {
            return currentVersion < minimumVersion;
        }
    }
}