using System;

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
            if ( string.IsNullOrEmpty( currentVersion ) ) return false;
            if ( string.IsNullOrEmpty( minimumVersion ) ) return false;

            try
            {
                return IsNeedUpdate
                (
                    currentVersion: int.Parse( currentVersion.Replace( ".", "" ) ),
                    minimumVersion: int.Parse( minimumVersion.Replace( ".", "" ) )
                );
            }
            catch ( FormatException )
            {
                return false;
            }
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