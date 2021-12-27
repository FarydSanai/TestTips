using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabGroup : MonoBehaviour
{
    [SerializeField] private Color deselectColor;
    public Color DeselectColor => deselectColor;
    [SerializeField] private Color hoverColor;
    [SerializeField] private Color selectColor;

    private TabButton selectedTab;
    private GameObject activeContent;

    public void OnTabEnter(TabButton tabButton)
    {
        if (selectedTab == null || tabButton != selectedTab)
        {
            tabButton.TabBackground.color = hoverColor;
        }
    }

    public void OnTabExit(TabButton tabButton)
    {
        if (selectedTab == null || tabButton != selectedTab)
        {
            tabButton.TabBackground.color = deselectColor;
        }
    }

    public void OnTabSelected(TabButton tabButton)
    {
        ToggleSelectedTab(tabButton);
        ToggleTabContent(tabButton.TabContent);
    }

    private void ToggleSelectedTab(TabButton tabButton)
    {
        if (selectedTab != null)
        {
            selectedTab.TabBackground.color = deselectColor;
        }
        selectedTab = tabButton;
        selectedTab.TabBackground.color = selectColor;
    }
    private void ToggleTabContent(GameObject contentObj)
    {
        activeContent?.SetActive(false);
        activeContent = contentObj;
        activeContent.SetActive(true);
    }
}
