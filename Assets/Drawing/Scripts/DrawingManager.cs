using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DrawingManager : MonoBehaviour
{
    public static DrawingManager instance;

    private List<GameObject> lines;

    private void Start()
    {
        instance = this;
        lines = new List<GameObject>();
    }

    public void AddLine(GameObject line) {
        lines.Add(line);
    }

    public void UndoLine() {
        if (lines.Count <= 0) {
            return;
        }

        Destroy(lines.Last());
        lines.Remove(lines.Last());
    }

    public List<GameObject> GetLines() {
        return lines;
    }
}
