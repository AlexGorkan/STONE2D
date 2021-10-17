using Spine.Unity;
using UnityEngine;

public class SpineTest : MonoBehaviour
{
    [SerializeField] private SkeletonAnimation _myAnimation;

    public void IdleAnimationPlay()
    {
        _myAnimation.state.SetAnimation(0, "Idle4", true);
    }

    public void WalkAnimationPlay()
    {
        _myAnimation.state.SetAnimation(0, "walk", true);
    }

    public void IdleWalkAnimationPlay()
    {
        float animTime = _myAnimation.Skeleton.Data.FindAnimation("Idle3").Duration;
        _myAnimation.state.SetAnimation(0, "Idle3", false);
        _myAnimation.state.AddAnimation(0, "walk", true, animTime);
    }
}
