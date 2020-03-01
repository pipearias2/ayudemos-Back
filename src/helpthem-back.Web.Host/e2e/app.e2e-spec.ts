import { helpthem-backTemplatePage } from './app.po';

describe('helpthem-back App', function() {
  let page: helpthem-backTemplatePage;

  beforeEach(() => {
    page = new helpthem-backTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
