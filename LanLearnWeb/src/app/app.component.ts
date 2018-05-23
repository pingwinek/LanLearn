import { Component, OnInit } from '@angular/core';
import { DictionaryService } from './dictionary.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'app';

  ngOnInit(): void {
    this.onGet();
  }

  constructor(private dictionaryService: DictionaryService) { }

  onGet() {
    this.dictionaryService.getDictionaries()
      .subscribe(response =>
        console.log(response)
      );
  }
}
