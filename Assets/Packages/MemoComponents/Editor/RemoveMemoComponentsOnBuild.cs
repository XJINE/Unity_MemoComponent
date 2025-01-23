// CAUTION:
// If you set the assembly definition to EditorOnly,
// it will no longer be able to attach the MemoComponent.
// And, simply placing it in the Editor folder will cause problems.
// "#if UNITY_EDITOR" is necessary.
#if UNITY_EDITOR

using RemoveOnBuilds;
public class RemoveMemoComponentsOnBuild : RemoveComponentsOnBuild<MemoComponent> { }

#endif // UNITY_EDITOR