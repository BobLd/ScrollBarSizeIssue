using Avalonia.Controls;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.VisualTree;
using System;
using System.Collections.Generic;
using Avalonia.LogicalTree;

namespace ScrollBarSizeIssue.Views
{
    internal class Test2LayoutTransformControl : LayoutTransformControl, IScrollSnapPointsInfo
    {
        private IScrollSnapPointsInfo? _scrollSnapPointsInfoImplementation;

        public override void ApplyTemplate()
        {
            base.ApplyTemplate();

            _scrollSnapPointsInfoImplementation = this.FindDescendantOfType<ItemsPresenter>().Panel as VirtualizingStackPanel;
        }

        protected override void OnAttachedToLogicalTree(LogicalTreeAttachmentEventArgs e)
        {
            base.OnAttachedToLogicalTree(e);
        }

        public IReadOnlyList<double> GetIrregularSnapPoints(Orientation orientation, SnapPointsAlignment snapPointsAlignment)
        {
            if (_scrollSnapPointsInfoImplementation is null)
            {
                _scrollSnapPointsInfoImplementation = this.FindDescendantOfType<ItemsPresenter>().Panel as VirtualizingStackPanel;
            }
            return _scrollSnapPointsInfoImplementation.GetIrregularSnapPoints(orientation, snapPointsAlignment);
        }

        public double GetRegularSnapPoints(Orientation orientation, SnapPointsAlignment snapPointsAlignment, out double offset)
        {
            if (_scrollSnapPointsInfoImplementation is null)
            {
                _scrollSnapPointsInfoImplementation = this.FindDescendantOfType<ItemsPresenter>().Panel as VirtualizingStackPanel;
            }
            return _scrollSnapPointsInfoImplementation.GetRegularSnapPoints(orientation, snapPointsAlignment, out offset);
        }

        public bool AreHorizontalSnapPointsRegular
        {
            get
            {
                if (_scrollSnapPointsInfoImplementation is null)
                {
                    _scrollSnapPointsInfoImplementation = this.FindDescendantOfType<ItemsPresenter>().Panel as VirtualizingStackPanel;
                }

                return _scrollSnapPointsInfoImplementation.AreHorizontalSnapPointsRegular;
            }
            set
            {
                if (_scrollSnapPointsInfoImplementation is null)
                {
                    _scrollSnapPointsInfoImplementation = this.FindDescendantOfType<ItemsPresenter>().Panel as VirtualizingStackPanel;
                }
                _scrollSnapPointsInfoImplementation.AreHorizontalSnapPointsRegular = value;
            }
        }

        public bool AreVerticalSnapPointsRegular
        {
            get
            {
                if (_scrollSnapPointsInfoImplementation is null)
                {
                    _scrollSnapPointsInfoImplementation =
                        this.FindDescendantOfType<ItemsPresenter>().Panel as VirtualizingStackPanel;
                }

                return _scrollSnapPointsInfoImplementation.AreVerticalSnapPointsRegular;
            }
            set
            {
                if (_scrollSnapPointsInfoImplementation is null)
                {
                    _scrollSnapPointsInfoImplementation =
                        this.FindDescendantOfType<ItemsPresenter>().Panel as VirtualizingStackPanel;
                }

                _scrollSnapPointsInfoImplementation.AreVerticalSnapPointsRegular = value;
            }
        }

        public event EventHandler<RoutedEventArgs>? HorizontalSnapPointsChanged
        {
            add
            {
                if (_scrollSnapPointsInfoImplementation is null)
                {
                    _scrollSnapPointsInfoImplementation = this.FindDescendantOfType<ItemsPresenter>().Panel as VirtualizingStackPanel;
                }
                _scrollSnapPointsInfoImplementation.HorizontalSnapPointsChanged += value;
            }
            remove => _scrollSnapPointsInfoImplementation.HorizontalSnapPointsChanged -= value;
        }

        public event EventHandler<RoutedEventArgs>? VerticalSnapPointsChanged
        {
            add
            {
                if (_scrollSnapPointsInfoImplementation is null)
                {
                    _scrollSnapPointsInfoImplementation = this.FindDescendantOfType<ItemsPresenter>().Panel as VirtualizingStackPanel;
                }
                _scrollSnapPointsInfoImplementation.VerticalSnapPointsChanged += value;
            }
            remove => _scrollSnapPointsInfoImplementation.VerticalSnapPointsChanged -= value;
        }
    }
}
