import { SampleTemplatePage } from './app.po';

describe('Sample App', function() {
  let page: SampleTemplatePage;

  beforeEach(() => {
    page = new SampleTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
