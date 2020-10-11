using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForSecondsManager
{
    class FloatComparer : IEqualityComparer<float>
    {
        bool IEqualityComparer<float>.Equals(float a, float b)
        {
            return Mathf.Approximately(a, b);
        }

        int IEqualityComparer<float>.GetHashCode(float obj)
        {
            return obj.GetHashCode();
        }
    }

    private readonly Dictionary<float, WaitForSeconds> waitForSeconds =
                new Dictionary<float, WaitForSeconds>(new FloatComparer());

    public WaitForSeconds GetTime(float time)
    {
        WaitForSeconds result;

        if (!waitForSeconds.TryGetValue(time, out result))
        {
            waitForSeconds.Add(time, result = new WaitForSeconds(time));
        }

        return result;
    }
}