using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading.Tasks;

namespace StarWarsAPI5.Shared
{
    public partial class Searcher
    {
        [Parameter]
        public EventCallback<string> OnTextChange { get; set; }
        [Parameter]
        public EventCallback OnClear { get; set; }
        private Subject<string> _subject = new Subject<string>();
        public Searcher()
        {
            _subject
                .Throttle(TimeSpan.FromMilliseconds(500))
                .DistinctUntilChanged()
                .Subscribe(async e =>
                {
                    await OnTextChange.InvokeAsync(e);
                });
        }
        private void OnInputChange(ChangeEventArgs e)
        {
            _subject.OnNext((string)e.Value);
        }
    }
}
