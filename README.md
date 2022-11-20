# Kogane Need Update Checker

アップデートが必要かどうかを確認するためのクラス

## 使用例

```cs
using Kogane;
using UnityEngine;

public sealed class Example : MonoBehaviour
{
    private void Start()
    {
        var isNeedUpdate = NeedUpdateChecker.IsNeedUpdate
        (
            currentVersion: Application.version,
            minimumVersion: "1.0.1"
        );

        Debug.Log( isNeedUpdate );
    }
}
```